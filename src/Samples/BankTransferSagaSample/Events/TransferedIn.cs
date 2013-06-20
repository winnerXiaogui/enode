﻿using System;
using BankTransferSagaSample.Domain;

namespace BankTransferSagaSample.Events
{
    [Serializable]
    public class TransferedIn : AbstractTransferEvent
    {
        public TransferedIn(Guid processId, TransferInfo transferInfo, string description)
            : base(processId, transferInfo, description)
        {
        }
    }
}
