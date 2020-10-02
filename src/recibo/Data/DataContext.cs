using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using recibo.Models;

namespace recibo.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        public DbSet<Recibo> Recibos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Recibo>()
                    .HasData(
                        new List<Recibo>(){
                            new Recibo(){
                                Id = 1,
                                NomeEmissor = "Marcia Amaral",
                                DocumentoEmissor = "12345678912",
                                TelefoneEmissor = "32991411071",
                                NomePagador = "Cliente Teste 1",
                                DocumentoPagador = "21987654321",
                                referente = "Pagamento para teste",
                                valor = 300.00M,
                                data ="01102020",
                                cidade = "Mirai",
                                FormaPagamento = "Dinheiro"
                            },
                            new Recibo(){
                                Id = 2,
                                NomeEmissor = "Marcia Amaral",
                                DocumentoEmissor = "12345678912",
                                TelefoneEmissor = "32991411071",
                                NomePagador = "Cliente Teste 2",
                                DocumentoPagador = "21987654321",
                                referente = "Pagamento para teste Novo",
                                valor = 300,
                                data ="02102020",
                                cidade = "Mirai",
                                FormaPagamento = "Cartao"
                            }
                            
                        }
                    );
        }
    
    }
}