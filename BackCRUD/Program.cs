using BackCRUD.Mapeamento;
using BackCRUD.Utilitarios;
using BackCRUD.DAO;
using BackCRUD.Mapeamento;

ConexaoBD.Conectar();
Console.WriteLine("Olá, mundooooooooooooooooooooo!");
ConexaoBD.Desconectar();

Aluno aluno = new Aluno();
AlunoDAO alunoDAO = new AlunoDAO();
ResponsavelAluno resp = new ResponsavelAluno();
ResponsavelAlunoDAO respo = new ResponsavelAlunoDAO();

try {
    //var alunos = alunoDAO.BuscarTodos();
    //foreach (var a in alunos) {
    //    Console.WriteLine($"ID: {a.IdAluno}, Nome: {a.NomeAlu}, CPF: {a.CpfAluno}, Telefone: {a.TelefoneAlu}, " +
    //        $"RG: {a.RgAlu}, Data Nasc: {a.DataNascAlu}, Resp: {a.Fk_id_responsavel}");
    //}
    //Console.Write("Digite o nome (ou parte do nome) do aluno para buscar: ");
    //string nomeBusca = Console.ReadLine();
    //Console.WriteLine();
    //Console.WriteLine();
    var respon = respo.BuscarTodos();
    foreach(var r in respon) {
        Console.WriteLine($"ID: {r.IdResp}, Nome: {r.NomeResp}, CPF: {r.CpfResp}, Telefone: {r.TelefoneResp}, " +
            $"RG: {r.RgResp}, Data Nasc: {r.DataNascResp}, Email: {r.EmailResp}, Parentesco: {r.ParentescoResp}");

    }

    //var alunos2 = alunoDAO.BuscarPorNome(nomeBusca);
    //Console.WriteLine();
    //foreach (var aa in alunos2) {
    //    Console.WriteLine($"ID: {aa.IdAluno}, Nome: {aa.NomeAlu}, CPF: {aa.CpfAluno}, Telefone: {aa.TelefoneAlu}, " +
    //        $"RG: {aa.RgAlu}, Data Nasc: {aa.DataNascAlu}, Resp: {aa.Fk_id_responsavel}");
    //}

} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
