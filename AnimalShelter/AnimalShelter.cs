namespace AnimalShelter;

public class AnimalShelter
{
    private LinkedList<Animal> _animals = new LinkedList<Animal>();

    private Dog? _lastDog;

    private Cat? _lastCat;

    public void Enqueue(Animal animal)
    {
        _animals.AddLast(animal);
        if (animal is Dog dog)
        {
            _lastDog = dog;
        }
        else if (animal is Cat cat)
        {
            _lastCat = cat;
        }
        else
        {
            throw new InvalidOperationException("We don't welcome such animal!");
        }
    }

    public Animal DequeueAny()
    {
        var animal = _animals.First();
        _animals.RemoveFirst();

        if (animal is Dog)
        {
            FindLastDog();
        }
        else
        {
            FindLastCat();
        }

        return animal;
    }

    public Cat? DequeueCat()
    {
        if (_lastCat == null)
        {
            return null;
        }

        _animals.Remove(_lastCat);
        FindLastCat();

        return _lastCat;
    }

    public Dog? DequeueDog()
    {
        if (_lastDog == null)
        {
            return null;
        }

        _animals.Remove(_lastDog);
        FindLastDog();

        return _lastDog;
    }

    private void FindLastDog()
    {
        _lastDog = null;
        var iterator = _animals.GetEnumerator();
        while (iterator.MoveNext())
        {
            if (iterator.Current is Dog lastDog)
            {
                _lastDog = lastDog;
                return;
            }
        }
    }

    private void FindLastCat()
    {
        _lastCat = null;
        var iterator = _animals.GetEnumerator();
        while (iterator.MoveNext())
        {
            if (iterator.Current is Cat lastCat)
            {
                _lastCat = lastCat;
                return;
            }
        }
    }
}