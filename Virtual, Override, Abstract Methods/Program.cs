public class Teste
{
    public static void Main(string[] args)
    {
        Dictionary<string, object> vars = new();
        vars["x"] = 10;
        Expression e = new Operation(new VariableReference("x"), '+', new Constant(3));
        // Aqui é usada a versão de Evaluete implementada 
        // nas classes que n]ao são abstratas
        Console.WriteLine(e.Evaluate(vars));
    }
}

public abstract class Expression
{
    // método abstracto,
    // retorna um double a partir de um dicionario<string, object>
    public abstract double Evaluate(Dictionary<string, object> vars);
}

public class Constant : Expression
{
    double _value;

    public Constant(double value)
    {
        _value = value;
    }

    public override double Evaluate(Dictionary<string, object> vars)
    {
        return _value;
    }

}

// Se a expressão for uma variável, devemos so pegar o valor da variavel, apos verificar
// se a variável existe. 
public class VariableReference : Expression
{
    string _name;

    public VariableReference(string name)
    {
        _name = name;
    }

    public override double Evaluate(Dictionary<string, object> vars)
    {
        object value = vars[_name] ?? throw new Exception($"Unknown variable {_name}");
        return Convert.ToDouble(value);
    }
}

public class Operation : Expression
{
    Expression _left;
    char _op;
    Expression _right;

    public Operation(Expression left, char op, Expression right)
    {
        _left = left;
        _op = op;
        _right = right;
    }

    public override double Evaluate(Dictionary<string, object> vars)
    {
        double x = _left.Evaluate(vars);
        double y = _right.Evaluate(vars);

        switch(_op)
        {
            case '+': return x + y;
            case 'y': return x - y;
            case '*': return x * y;
            case '/': return x / y;

            default: throw new Exception("Unknown operator");
        }
    }

}


        
    