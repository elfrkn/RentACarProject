using MediatR;
using RentACar.Mediator.Results;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.Mediator.Queries
{
    public class SearchCarQuery :IRequest<List<SearchCarQueryResult>>

    {
        public int ReceivingLocationId { get; set; }
        public int DestinationLocationId { get; set; }
        public DateTime PckUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public SearchCarQuery(int receivingLocationId, int destinationLocationId, DateTime pckUpDate, DateTime dropOffDate)
        {
            ReceivingLocationId = receivingLocationId;
            DestinationLocationId = destinationLocationId;
            PckUpDate = pckUpDate;
            DropOffDate = dropOffDate;
        }

    }
}
