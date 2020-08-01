using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.Models
{
    /// <summary>
    /// An Enum for the transfer type
    /// </summary>
    public enum TransferType
    {
        Request = 1,
        Send = 2
    }
    /// <summary>
    /// An Enum for the transfer status
    /// </summary>
    public enum TransferStatus
    {
        Pending = 1,
        Approved = 2,
        Rejected = 3
    }
    //TODO: Make comments for each prop for swagger.
    public class Transfer
    {
        public int TransferId { get; set; }
        public TransferType TransferType { get; set; } = TransferType.Send;
        public TransferStatus TransferStatus { get; set; } = TransferStatus.Pending;
        [Required]
        public ReturnUser AccountFrom { get; set; }
        [Required]
        public ReturnUser AccountTo { get; set; }
        [Required]
        [Range(0, 10000)]
        public decimal Amount { get; set; }
    }
}
