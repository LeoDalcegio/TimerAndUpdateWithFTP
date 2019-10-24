using System;
using System.Net;
using System.IO;

namespace TesteFTP
{
    class FTP
    {
        // testar para ver se sobreescreve arq existente, 
        // tem como deletar o arquivo fora daqui tbm

        protected async void BaixarArquivoFTP(string urlServidor, string dirLocal, string usuario, string senha) 
        {
            try 
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(urlServidor));

                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(usuario, senha);
                request.UseBinary = true;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse()) {
                    using (Stream rs = response.GetResponseStream()) { 
                        using (FileStream ws = new FileStream(dirLocal, FileMode.Create)) {
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }           
        }
    }
}
