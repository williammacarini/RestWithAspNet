using System.Collections.Generic;

namespace RestWithAspNet.Data.Contract
{
    public interface IParser<O, D>
    {
        D Parse(O origin);

        List<D> Parse(List<O> origin);
    }
}
