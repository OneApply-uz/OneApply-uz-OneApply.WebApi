﻿

namespace DTOAccessLayer.Dtos.CertificateDtos;

public class CertificateDto:BaseDto
{

    public string Name { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public int UserId { get; set; }
}
