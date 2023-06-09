using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDLLTefClientMC_TransparenteCSharp
{
    class Util
    {
        public static List<string> WordWrap(string text, int maxLineLength)
        {
            var list = new List<string>();

            int currentIndex;
            var lastWrap = 0;
            var whitespace = new[] { ' ', '\r', '\n', '\t' };
            do
            {
                currentIndex = lastWrap + maxLineLength > text.Length ? text.Length : (text.LastIndexOfAny(new[] { ' ', ',', '.', '?', '!', ':', ';', '-', '\n', '\r', '\t' }, Math.Min(text.Length - 1, lastWrap + maxLineLength)) + 1);
                if (currentIndex <= lastWrap)
                    currentIndex = Math.Min(lastWrap + maxLineLength, text.Length);
                list.Add(text.Substring(lastWrap, currentIndex - lastWrap).Trim(whitespace));
                lastWrap = currentIndex;
            } while (currentIndex < text.Length);

            return list;
        }

        public static void AdicionaLog(string strMsg, string strStackTrace = null)
        {
            CriarArquivo("tef", strMsg, strStackTrace);
        }

        private static void CriarArquivo(string sNomeArquivo, string strMsg, string strStackTrace = "")
        {

            if (string.IsNullOrEmpty(strMsg) && string.IsNullOrEmpty(strStackTrace)) return;

            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}nlog.txt")) return;

            if (string.IsNullOrEmpty(sNomeArquivo)) return;

            if (ArquivoEmUso(AppDomain.CurrentDomain.BaseDirectory + $"{sNomeArquivo}.log")) return;

            try
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                
                string version = fvi.FileVersion;

                FileInfo info = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + $"{sNomeArquivo}.log");
                if (info.Exists && info.Length >= 314572800)
                {
                    try
                    {
                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + $"{sNomeArquivo}_old.log");
                        File.Move(AppDomain.CurrentDomain.BaseDirectory + $"{sNomeArquivo}.log", AppDomain.CurrentDomain.BaseDirectory + $"{sNomeArquivo}_old.log");
                       
                    }
                    catch { }
                }

                var objLog = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + $"{sNomeArquivo}.log", true);

                if (strMsg != "")
                    objLog.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff") + $" v. {version}" + " :: " + strMsg);

                if (!string.IsNullOrEmpty(strStackTrace))
                    objLog.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff") + $" v. {version}" + " :: " + strStackTrace);

                objLog.Close();
                objLog.Dispose();
                objLog = null;
            }
            catch { }
        }

        public static bool ArquivoEmUso(string caminhoArquivo)
        {
            try
            {
                System.IO.FileStream fs = System.IO.File.OpenWrite(caminhoArquivo);
                fs.Close();
                return false;
            }
            catch
            {
                return true;
            }
        }
    }
}
