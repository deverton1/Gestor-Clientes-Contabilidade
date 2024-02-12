using Dapper;
using Domain.Command;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Data.SqlClient;
using Microsoft.OpenApi.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmpresasRepository : IEmpresasRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=SLCLIENTES;Trusted_Connection=True;MultipleActiveResultSets=true";

        public async Task<string> AtualizarEmpresa(int empresaId, EmpresaCommand command)
        {
            string queryUpdateEmpresa = @"UPDATE Empresas SET
                                          RazaoSocial = @RazaoSocial,
                                          Cnpj = @Cnpj,
                                          NomeRepresentante = @NomeRepresentante,
                                          CpfRepresentante = @CpfRepresentante,
                                          CodigoSimplesNacio = @CodigoSimplesNacio,
                                          Logradouro = @Logradouro,
                                          Tributacao = @Tributacao,
                                          Porte = @Porte,
                                          DataAbertura = @DataAbertura
                                          WHERE Id = @empresaId";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryUpdateEmpresa, new
                {
                    empresaId = empresaId,
                    RazaoSocial = command.RazaoSocial,
                    Cnpj = command.Cnpj,
                    NomeRepresentante = command.NomeRepresentante,
                    CpfRepresentante = command.CpfRepresentante,
                    CodigoSimplesNacio = command.CodigoSimplesNacio,
                    Logradouro = command.Logradouro,
                    Tributacao = command.Tributacao,
                    Porte = command.Porte,
                    DataAbertura = command.DataAbertura
                });
                return "Empresa atualizada com SUCESSO!";
            }
        }

        public async Task<string> CadastrarEmpresa(EmpresaCommand command)
        {
            string queryCadastrarEmpresa = @"INSERT INTO Empresas (RazaoSocial,Cnpj,NomeRepresentante,CpfRepresentante,
                                            CodigoSimplesNacio,Logradouro,Tributacao,Porte,DataAbertura)
                                             VALUES (@RazaoSocial,@Cnpj,@NomeRepresentante,@CpfRepresentante,
                                            @CodigoSimplesNacio,@Logradouro,@Tributacao,@Porte,@DataAbertura)";
            using (SqlConnection conn  = new SqlConnection(conexao))
            {
                conn.Execute(queryCadastrarEmpresa, new
                {
                    RazaoSocial = command.RazaoSocial,
                    Cnpj = command.Cnpj,
                    NomeRepresentante = command.NomeRepresentante,
                    CpfRepresentante = command.CpfRepresentante,
                    CodigoSimplesNacio = command.CodigoSimplesNacio,
                    Logradouro = command.Logradouro,
                    Tributacao = command.Tributacao,
                    Porte = command.Porte,
                    DataAbertura = command.DataAbertura
                });
                return "Empresa cadastrada com sucesso!";
                
            }
        }

        public async Task<IEnumerable<EmpresaCommand>> GetAllAsync()
        {
            string queryListar = @"SELECT * FROM Empresas";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
               return conn.QueryAsync<EmpresaCommand>(queryListar).Result.ToList();
            }
            
        }
    }
}
