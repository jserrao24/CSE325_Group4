﻿namespace QuickStay;

public class Address
{
    public int Id { get; set; }
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }

    public required string PostalCode { get; set; }
}
