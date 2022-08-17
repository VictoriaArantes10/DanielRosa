using Cadastro.Models;

namespace Cadastro.Data
{
    public class AppDBCadastro
    {
        public static void  Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCad>();
                context.Database.EnsureCreated();

                //Cadastro do Usuário

                if(!context.Pessoa.Any())
                {
                    context.Pessoa.AddRange(new List<Pessoa>()
                     {
                        new Pessoa()
                        {
                            Nome="Victória Arantes",
                            Telefone = "(16) 993633527",
                            Email ="victoria@arantes.com",
                            Endereco="Rua Avail n155"
                        },

                        new Pessoa()
                        {
                            Nome = "Sebastião Neto",
                            Telefone = "(16) 4843348344",
                            Email = "sebastiao@neto.com",
                            Endereco = "Rua Acaru n4637",
                        },

                        new Pessoa()
                        {
                            Nome = "Daniel Rosa",
                            Telefone = "(16) 95934843934",
                            Email = "daniel@rosa.com",
                            Endereco = "Rua Airton n880",
                        },

                         new Pessoa()
                        {
                            Nome = "Leonardo Chinarelo",
                            Telefone = "(16) 84843843",
                            Email = "leonardo@hotmail.com",
                            Endereco = "Rua Marcel n776",
                        },

                          new Pessoa()
                        {
                            Nome = "Juliana Afonsa",
                            Telefone = "(16) 8473878943",
                            Email = "julia@gmail.com",
                            Endereco = "Rua Maidil 208",
                        },
                      });
                    context.SaveChanges();
                }
            }

        }
    }
}
