﻿namespace DP.Logic.Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague collegue);
    }
}
