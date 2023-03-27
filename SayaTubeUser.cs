using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul6_1302213109
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string nama)
        {

            if (nama == null || nama.Length > 100)
            {
                throw new ArgumentException("Username harus berisi max 100 karakter");
            }
        }

        public int GetTotalVideoPlayCount()
        {
            int test = 0;
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                test = test + uploadedVideos[i].getPlayCount();
            }
            return test;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            if (uploadedVideos == null)
            {
                Console.WriteLine("Tidak ada video");
            }
            else
            {
                while (uploadedVideos.Count > 0)
                {
                    Console.WriteLine("User: " + Username);
                }
            }
        }
    }
}
