using BackCRUD.Mapeamento;
using BackCRUD.Utilitarios;

ConexaoBD.Conectar();
Console.WriteLine("Olá, mundooooooooooooooooooooo!");
ConexaoBD.Desconectar();

Aluno aluno = new Aluno();
ResponsavelAluno resp = new ResponsavelAluno();
try {
    aluno.CpfAluno = "047.170.942-55";
    resp.CpfResp = "59816660210";

} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
