using Funcionarios.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace Funcionarios.Data.SeedData
{
    public class SexoSeedData : DropCreateDatabaseIfModelChanges<FuncionariosEntities>
    {
        protected override void Seed(FuncionariosEntities context)
        {
            Sexos().ForEach(c => context.Sexo.Add(c));

            context.Commit();
        }

        private static List<Sexo> Sexos()
        {
            return new List<Sexo>
            {
                new Sexo {
                    Descricao = "Masculino"
                },
                new Sexo {
                    Descricao = "Feminino"
                }
            };
        }
    }
}
