﻿using SharpNTCIP.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpNTCIP.DMS
{
    [NtcipOid("1.3.6.1.4.1.1206.4.2.3.3.4")]
    public class CharacterInfoList : SharpNTCIP.Table<Tuple<UInt16>,ICharacterEntry>
    {
    }
}
