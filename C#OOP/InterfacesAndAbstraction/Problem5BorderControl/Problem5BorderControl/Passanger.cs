﻿namespace Problem5BorderControl
{
    public abstract class Passanger
    {
        public Passanger(string id)
        {
            this.Id = id;
        }

        public string Id { get; }
    }
}
