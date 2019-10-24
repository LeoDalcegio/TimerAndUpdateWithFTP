using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using TesteFTP.Util;

namespace TesteFTP.XML
{
    class FuncoesXML
    {
        DadosUsuario _dados;
        readonly string _DiretorioDadosTela;
        readonly Diretorios _diretorios;

        public FuncoesXML(DadosUsuario dados)
        {
            _dados = dados;
            _diretorios = new Diretorios(dados);
            _DiretorioDadosTela = _diretorios.DiretorioDadosTelaXML();
        }

        public FuncoesXML()
        {
            _diretorios = new Diretorios();
            _DiretorioDadosTela = _diretorios.DiretorioDadosTelaXML();
        }


        public void SalvaDadosTela()
        {

            //diretorios.CriaDiretorio(_DiretorioDadosTela);
            try
            {
                XmlTextWriter writer = new XmlTextWriter(_DiretorioDadosTela + ".xml", null);

                writer.WriteStartDocument();
                writer.WriteStartElement("DadosTela");
                writer.WriteElementString("BaixarPara", _dados.BaixarPara);
                writer.WriteElementString("DirArqServidor", _dados.DirArqServidor);
                writer.WriteElementString("EnderecoServidor", _dados.EnderecoServidor);
                writer.WriteElementString("Senha", _dados.Senha);
                writer.WriteElementString("Usuario", _dados.Usuario);
                writer.WriteEndElement();

                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public DadosUsuario BuscaDadosTelaSalvo()
        {
            try
            {
                FileStream stream = new FileStream(_DiretorioDadosTela, FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(DadosUsuario));
                _dados = (DadosUsuario)desserializador.Deserialize(stream);

                return _dados;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
