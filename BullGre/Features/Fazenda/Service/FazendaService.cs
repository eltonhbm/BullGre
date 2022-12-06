using BullGre.Features.Fazenda.Model;
using Microsoft.EntityFrameworkCore;

namespace BullGre.Features.Fazenda.Service
{
    public class FazendaService
    {
        private Data.AppDbBullGre dbContext;

        public FazendaService(Data.AppDbBullGre dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<FazendaModel>> ListarFazendas()
        {
            return await dbContext.Fazenda.ToListAsync();
        }

        public async Task<FazendaModel> Inserir(FazendaModel fazenda)
        {
            try
            {
                dbContext.Fazenda.Add(fazenda);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return fazenda;
        }

        public async Task<FazendaModel> Atualizar(FazendaModel fazenda)
        {
            try
            {
                if (dbContext.Fazenda.FirstOrDefault(f => f.Id == fazenda.Id) != null)
                {
                    dbContext.Fazenda.Update(fazenda);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return fazenda;
        }

        public async Task Apagar(FazendaModel fazenda)
        {
            try
            {
                dbContext.Fazenda.Remove(fazenda);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
