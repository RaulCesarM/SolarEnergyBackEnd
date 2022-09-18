
namespace SolarEnergy.Domain.Models
{
    public class Paginacao
    {
        public Paginacao(int take, int skip)
        {
            Take = take;
            Skip = skip;
        }

        public int Take { get; set; }
        public int Skip { get; set; }
    }
}