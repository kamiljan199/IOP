using System;
using System.Collections.Generic;
using System.Text;
using Api.Enums;

namespace Api.DTOs
{
    public class TestDTO
    {
        public TestStatus Status { get; set; }
        public string ReceiverName { get; set; }
        public string SenderName { get; set; }
        public int StoragePointId { get; set; }
    }
}
