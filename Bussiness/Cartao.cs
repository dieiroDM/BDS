using System;
using System.IO;

namespace Bussiness
{
    public class Cartao
    {
        public string nomeA, nMat, curso, dataE, dataV;
        public byte[] fotoCard;
        public bool certo = false;
        byte[] foto = null;
        public string BI { get; set; }
        public string caminhoFoto { get; set; }

        public void ADD_C()
        {
            try
            {
                tratamentoFoto();
                certo = true;
            }
            catch
            {
                certo = false;
            }
        }

        public void PesquisaCartao(int id)
        {
            try
            {
                Database.Cartao card = new Database.Cartao();
                card.PesquisaCartao(id);
                nomeA = card.nomeA;
                nMat = card.nMat;
                curso = card.curso;
                dataE = card.dataE;
                dataV = card.dataV;
                fotoCard = card.fotoIMG;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tratamentoFoto()
        {
            try
            {
                FileStream Stream = new FileStream(this.caminhoFoto, FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(Stream);
                foto = binario.ReadBytes((int)Stream.Length);

                inserirCartao();
                certo = true;
            }
            catch
            {
            }
        }

        private void inserirCartao()
        {
            try
            {
                string dataE = DateTime.Now.ToString("dd-MM-yyy");
                string dataV = DateTime.Now.ToString("dd-MM") + "-" + (DateTime.Now.Year + 3).ToString();

                new Database.Cartao().addCartao(this.BI, dataE, dataV, this.foto);
                certo = true;
            }
            catch { }
        }

        public void via2cartao(int cardID)
        {
            string dataE = DateTime.Now.ToString("dd-MM-yyy");
            string dataV = DateTime.Now.ToString("dd-MM") + "-" + (DateTime.Now.Year + 3).ToString();
            new Database.Cartao().add2viaCartao(cardID, dataE, dataV);
            certo = true;
        }
        public int CartoesEmitidos()
        {
            return new Database.Cartao().CartoesEmitidos();
        }

        public int CartoesAtivos()
        {
            return new Database.Cartao().CartoesAtivos();
        }

        public int CartoesInvalidos()
        {
            return new Database.Cartao().CartoesInvalidos();
        }
    }
}
