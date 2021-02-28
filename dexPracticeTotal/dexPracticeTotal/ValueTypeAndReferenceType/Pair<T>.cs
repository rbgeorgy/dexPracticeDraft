namespace ValueTypeAndReferenceTypeClassLibrary
{
    public struct Pair<T>
    {
        public T first, second;

        public Pair(T first, T second)
        {
            this.first = first;
            this.second = second;
        }
    }
}