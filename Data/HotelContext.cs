namespace PruebaTecnica.Data;
{
    public class HotelContext:DbContext{
        public HotelContext(DbContextOptions<HotelContext> options):base(options){

        }

        
    }
}