using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Serializable
{
    [Serializable]
    public class Mensaje
    {
        public string Maquina { get; set; }
        public string Tela { get; set; }
        public string Cliente { get; set; }
        public string Cantidad { get; set; }
        public string CalidadTela { get; set; }

        public static int contadorXmlGuardados = 0;
        public static int contadorTxtGuardados = 0;

        /// <summary>
        /// Constructor que permite poder Serializar
        /// </summary>
        public Mensaje()
        {
        }
        /// <summary>
        /// Constructor de Mensaje con todos sus parametros
        /// </summary>
        /// <param name="maquina"></param>
        /// <param name="tela"></param>
        /// <param name="cliente"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidadTela"></param>
        public Mensaje(string maquina, string tela, string cliente, string cantidad, string calidadTela)
        {
            Maquina = maquina;
            Tela = tela;
            Cliente = cliente;
            Cantidad = cantidad;
            CalidadTela = calidadTela;
        }
        /// <summary>
        /// Sobreescritura de ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarCampos();
        }
        /// <summary>
        /// Retorna el string del mensaje creado
        /// </summary>
        /// <returns></returns>
        public string MostrarCampos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Maquina:{Maquina};");
            sb.Append($"Tela:{Tela};");
            sb.Append($"Cliente:{Cliente};");
            sb.Append($"Cantidad:{Cantidad};");
            sb.Append($"Calidad Tela:{CalidadTela};");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="listaMensaje"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool operator ==(List<Mensaje> listaMensaje, Mensaje mensaje)
        {
            bool retorno = false;
            foreach (Mensaje item in listaMensaje)
            {
                if (mensaje.Maquina.Equals(item.Maquina) &&
                    mensaje.Cliente.Equals(item.Cliente) &&
                    mensaje.Cantidad.Equals(item.Cantidad) &&
                    mensaje.Tela.Equals(item.Tela) &&
                    mensaje.CalidadTela.Equals(item.CalidadTela))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="listaMensaje"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool operator !=(List<Mensaje> listaMensaje, Mensaje mensaje)
        {
            return !(listaMensaje == mensaje);
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="misMensajes"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static List<Mensaje> operator +(List<Mensaje> misMensajes, Mensaje mensaje)
        {
            if (misMensajes != mensaje)
            {
                misMensajes.Add(mensaje);
            }
            return misMensajes;
        }
        /// <summary>
        /// Permite guardar el mensaje en formato TXT
        /// </summary>
        /// <returns></returns>
        public bool GuardarTxt()
        {
            try
            {
                contadorTxtGuardados++;
                StreamWriter streamWriter = new StreamWriter($"{contadorTxtGuardados} - {Tela}.txt");
                streamWriter.WriteLine(MostrarCampos().Replace('\n', ';'));
                streamWriter.Close();
                return File.Exists($"{contadorTxtGuardados} - {Tela}.txt");
            }
            catch (Exception )
            {
                throw new ErrorGuardarException("Hubo un error en el guardado de archivos");
            }
        }
        /// <summary>
        /// permite guardar el mensaje en formato XML
        /// </summary>
        public void GuardarXml()
        {

            try
            {
                contadorXmlGuardados++;
                XmlTextWriter xmlTextWriter = new XmlTextWriter($"{contadorXmlGuardados}.xml", Encoding.UTF8);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Mensaje));
                xmlSerializer.Serialize(xmlTextWriter, this);
                xmlTextWriter.Close();
            }
            catch (Exception )
            {
                throw new ErrorGuardarException("Hubo un error en el guardado de archivos");
            }
        }
        /// <summary>
        /// permite guardar el mensaje en formato XML
        /// </summary>
        public static List<Mensaje> CargarXml()
        {
            int i = 0;
            List<Mensaje> listaMensajesAleer = new List<Mensaje>();
            try
            {
                while (true)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Mensaje));
                    if (File.Exists($"{i}.xml"))
                    {
                        XmlTextReader xmlReader = new XmlTextReader(AppDomain.CurrentDomain.BaseDirectory + i + ".xml");

                        listaMensajesAleer.Add((Mensaje)xmlSerializer.Deserialize(xmlReader));

                        xmlReader.Close();
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                return listaMensajesAleer;
            }
            catch (Exception )
            {
                throw new ErrorCargarException("Hubo un error en la lectura de archivos");
            }
        }
    }
}
