using System;
using System.IO;

namespace ExedePrueba.Bll
{
    public class Utilidades : IDisposable
    {
        private bool disposing = false;

        public string ConvertirStreamXBase64(Stream fs)
        {
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);
            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            return $"data:image/png;base64,{base64String}";
        }

        public void Dispose()
        {
            if (disposing)
            {
                return;
            }
            disposing = true;
        }
    }
}