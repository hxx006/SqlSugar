﻿namespace SqlSugar
{
    public class SqliteQueryable<T>:QueryableProvider<T> 
    {
        public override ISugarQueryable<T> With(string withString)
        {
            return this;
        }
    }
    public class SqliteQueryable<T,T2> : QueryableProvider<T,T2>
    {

    }
    public class SqliteQueryable<T, T2,T3> : QueryableProvider<T, T2,T3>
    {

    }
    public class SqliteQueryable<T, T2,T3,T4> : QueryableProvider<T, T2,T3,T4>
    {

    }
    public class SqliteQueryable<T, T2, T3, T4, T5> : QueryableProvider<T, T2, T3, T4, T5>
    {

    }
    public class SqliteQueryable<T, T2, T3, T4, T5, T6> : QueryableProvider<T, T2, T3, T4, T5, T6>
    {

    }
    public class SqliteQueryable<T, T2, T3, T4, T5, T6, T7> : QueryableProvider<T, T2, T3, T4, T5, T6, T7>
    {

    }
    public class SqliteQueryable<T, T2, T3, T4, T5, T6, T7, T8> : QueryableProvider<T, T2, T3, T4, T5, T6, T7, T8>
    {

    }
}
