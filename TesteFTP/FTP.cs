using System;
using System.Net;
using System.IO;

namespace TesteFTP
{
    class FTP
    {
        //definir uma classe com os dados necessários para realizar essas operações e usar a classe como parâmetro desses métodos.
        
        //retornar List de arquivos e p/ cada item na lista realizar o upload/ download
        public async void EnviarArquivoFTP(string arquivo, string url, string usuario, string senha) {
            try {  
                FileInfo arquivoInfo = new FileInfo(arquivo);

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(url));

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(usuario, senha);
                request.UseBinary = true;
                request.ContentLength = arquivoInfo.Length;

                using (FileStream fs = arquivoInfo.OpenRead()) {
                    byte[] buffer = new byte[2048];
                    int bytesSent = 0;
                    int bytes = 0;
                    using (Stream stream = request.GetRequestStream()) {
                        while (bytesSent < arquivoInfo.Length) {
                            bytes = fs.Read(buffer, 0, buffer.Length);
                            await stream.WriteAsync(buffer, 0, bytes);
                            bytesSent += bytes;
                        }
                    }
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        // timer para chamar método em determinado horario
        // busca arq alterados
        // lista com as url alterado
        // loop no baixarArq com cada arquivo da lista


        // txtArquivoDownload.Text, txtBaixarPara.Text, txtUsuario.Text, txtSenha.Text
        public async void BaixarArquivoFTP(string url, string local, string usuario, string senha) {
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
