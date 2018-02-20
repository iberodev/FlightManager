using System;

namespace FlightManager.Data.Models
{
    public interface IModel
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        bool IsDeleted { get; set; }
    }
}
