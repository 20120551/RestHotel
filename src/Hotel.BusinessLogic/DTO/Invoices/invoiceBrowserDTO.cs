﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BusinessLogic.DTO.Invoices;

public class invoiceBrowserDTO
{
    public int Id { get; set; }
    public int RoomId { get; set; }
    public DateTime Date { get; set; }
}
