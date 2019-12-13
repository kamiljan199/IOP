using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    public interface IEntityConfiguration
    {
        void AddConfiguration(ModelBuilder modelBuilder);
    }
}
