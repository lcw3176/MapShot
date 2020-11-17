using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MapShot
{
    

    public class CaptureManager
    {
        public delegate void AddProgress(int value);
        public event AddProgress add;
        private List<string> fileName = new List<string>();
        private const int width = 1024;
        private const int height = 942;

        private KaKaoAPI kakao = new KaKaoAPI();


        public void StartCapture(string qstr, int blockNum, string topPath, string zoom)
        {
            List<string> locale = kakao.Search(qstr);

            // [0] 장소
            // [1] 경도 ==> 1초 : 24.697미터, 가로, 증가할수록 오른쪽, 18 기준: 0.0055 한칸, 17 기준: 0.011
            // [2] 위도 ==> 1초: 30.828미터, 세로, 증가할수록 위족,  18 기준: 0.004 한칸, 17 기준: 0.008

            // zoom level
            // 18 == 30m
            // 17 == 50m
            // 16 == 100m
            // 15 == 250m

            try
            {
                string place = locale[0];
                double lng = double.Parse(locale[1].Substring(0, 8));
                double lat = double.Parse(locale[2].Substring(0, 7));

                int count = 0;
                int rotation = (int)Math.Sqrt(blockNum);
                int moveTopCoor = (rotation / 2);

                double lngFlag = 0.011;
                double latFlag = 0.008;

                string path = Path.Combine(topPath, place);
                string addressFileName;


                if (zoom == "18") { lngFlag /= 2; latFlag /= 2; path += "[초고화질]"; }


                lng -= lngFlag * moveTopCoor;
                lat += latFlag * moveTopCoor;

                DirectoryInfo di = new DirectoryInfo(path);

                if (!di.Exists) { di.Create(); }

                for (int i = 0; i < rotation; i++)
                {
                    for (int j = 0; j < rotation; j++)
                    {
                        addressFileName = string.Format("{0}[{1}]", place, count.ToString());
                        GetImageFromUrl(lng.ToString(), lat.ToString(), path, addressFileName, zoom);
                        lng += lngFlag;
                        add(++count);
                    }

                    lng -= (lngFlag * rotation);
                    lat -= latFlag;
                }

                MakeOneShot(blockNum, path, place);
                add(++count);

                MessageBox.Show("작업이 완료되었습니다.", "알림");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("입력된 정보가 부정확합니다.", "알림");
            }
        }

        private void GetImageFromUrl(string lng, string lat, string path, string addressFileName, string zoom)
        {
            string url = "http://api.vworld.kr/req/image?service=image&request=getmap"; // &key=인증키&[요청파라미터]
            string key = "개발자 키";
            string baseMap = "PHOTO";
            string center = lng + "," + lat;
            string crs = "epsg:4326";
            string size = "1024,1024";
            string form = "jpeg";

            string query = string.Format("&key={0}&basemap={1}&center={2}&crs={3}&zoom={4}&size={5}&format={6}", key, baseMap, center, crs, zoom, size, form);

            string requestUrl = string.Format("{0}{1}", url, query);

            try
            {
                WebRequest request = WebRequest.Create(requestUrl);
                WebResponse response = request.GetResponse();
                Stream data = response.GetResponseStream();
               
                // 원본 사이즈 1024 1024
                // 로고 커팅, 다른 사진과 병합 시
                // 82만큼 커트가 가장 깔끔
                
                Bitmap bitmap = new Bitmap(data);

                string savePath = string.Format(@"{0}\{1}.jpg", path, addressFileName);
                
                Bitmap clone = bitmap.Clone(new Rectangle(0, 0, width, height), PixelFormat.DontCare);
                clone.Save(savePath, ImageFormat.Jpeg);
                fileName.Add(savePath);
                
                data.Dispose();
                clone.Dispose();
                bitmap.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void MakeOneShot(int blockNum, string path, string addressFileName)
        {
            int root = (int)Math.Sqrt(blockNum);

            using (Bitmap bitmap = new Bitmap(width * root, height * root))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int i = 0; i < blockNum; i++)
                {
                    Image img = Image.FromFile(fileName[i]);
                    g.DrawImage(img, (i % root) * width, (i / root) * height);
                    img.Dispose();
                }

                bitmap.Save(Path.Combine(path, addressFileName + " 병합사진.jpg"), ImageFormat.Jpeg);

                fileName.Clear();
            }
        }
        
    }
}
