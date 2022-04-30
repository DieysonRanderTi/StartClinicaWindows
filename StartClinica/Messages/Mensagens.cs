using System.Windows.Forms;

namespace StartClinica.Mensagem
{
    public static class Mensagens
    {
        public static void CadastroSucesso()
        {
            MessageBox.Show("Cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void CadastroSucessoComParametros(string mensagem, string titulo)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void CadastroErro()
        {
            MessageBox.Show("Erro ao cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ErroParametros(string mensagem, string titulo)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
