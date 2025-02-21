﻿using System;
using System.Collections.Generic;

namespace Siscan_Vc_DAL.DataContext;

public partial class ConvocatoriaTyt
{
    public int IdConvocatoria { get; set; }

    public DateOnly? FechaPresentacion { get; set; }

    public int? SemestreConvocatoria { get; set; }

    public virtual ICollection<InscripcionTyt> InscripcionTyts { get; set; } = new List<InscripcionTyt>();
}
