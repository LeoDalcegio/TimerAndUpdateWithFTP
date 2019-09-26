using System;
using System.Net;
using System.IO;

namespace TesteFTP
{
    class FTP
    {
        // serviço do windows para determinado horario
        // retornar List de arquivos, dos que tem que baixar 
        // p/ cada item na lista realizar o download

        protected async void BaixarArquivoFTP(string url, string local, string usuario, string senha) {
            try {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(url));

                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(usuario, senha);
                request.UseBinary = true;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse()) {
                    using (Stream rs = response.GetResponseStream()) {
                        using (FileStream ws = new FileStream(local, FileMode.Create)) {
                            byte[] buffer = new byte[2048];
                            int bytesRead = rs.Read(buffer, 0, buffer.Length);
                            while (bytesRead > 0) {
                                ws.Write(buffer, 0, bytesRead);
                                bytesRead = await rs.ReadAsync(buffer, 0, buffer.Length);
                            }
                        }
                    }
                }
            }
            catch {
                throw; 
            }           
        }
    }
}
