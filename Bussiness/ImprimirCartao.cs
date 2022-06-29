using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Bussiness
{
    public class ImprimirCartao
    {

        public ImprimirCartao(string nome, string nMat, string curso, string dataE, string dataV)
        {

            string ModeloCartao = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments).ToString() + @"\modeloCartao.docx";

            if((Directory.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments).ToString() + @"\Cartoes_Emitidos")) == false)
            {
                Directory.CreateDirectory(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Cartoes_Emitidos"));
            }
            
            string pasta_salvar = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments).ToString() + @"\Cartoes_Emitidos\Cartao de " + nome+".docx";

            CriarDOC(ModeloCartao, pasta_salvar, nome, nMat, curso, dataE, dataV);
        }
        
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object macthcase = true;
            object macthWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref macthcase, ref macthWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza, ref matchControl
                );

        }

        private void CriarDOC(object filename, object SaveAs, string nome, string nMat, string curso, string dataE, string dataV)
        {
            Word.Application wordApp = new Word.Application();

            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

                myWordDoc.Activate();

                this.FindAndReplace(wordApp, "<nome>", nome);
                this.FindAndReplace(wordApp, "<n_matricula>", nMat);
                this.FindAndReplace(wordApp, "<curso>", curso);
                this.FindAndReplace(wordApp, "<emitido>", dataE);
                this.FindAndReplace(wordApp, "<validade", dataV);

            }
            else
            {
                MessageBox.Show("Erro no Modelo do Cartão");
            }

            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
        }
    }


}
