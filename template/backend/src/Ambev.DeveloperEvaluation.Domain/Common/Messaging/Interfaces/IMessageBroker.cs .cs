﻿using Ambev.DeveloperEvaluation.Domain.Common.Messaging.Events;
namespace Ambev.DeveloperEvaluation.Domain.Common.Messaging.Interfaces;
public interface IMessageBroker
{
    void PublishEvent(string message, IDomainEvent domainEvent);
}
