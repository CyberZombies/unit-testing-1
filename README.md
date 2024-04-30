classDiagram
    class AdditionOperations {
        +static Add(int, int) int
    }
    
    class SubtractionOperations {
        +static Subtract(int, int) int
    }
    
    class MultiplicationOperations {
        +static Multiply(int, int) int
    }
    
    class DivisionOperations {
        +static Divide(int, int) int
        +static Modulo(int, int) int
    }
    
    class ArithmeticOperationsExample {
        +AdditionExample()
        +SubtractionExample()
        +MultiplicationExample()
        +DivisionExample()
    }
    
    class Khinkali {
        +PrepareDough() string
        +PrepareFilling() string
    }
    
    class KhinkaliWithCheeseAndMushrooms {
        -int flourAmount
        -int waterAmount
        -int saltAmount
        -int cheeseAmount
        -int mushroomsAmount
        -int onionAmount
        -int spicesAmount
        -int eggAmount
        +KhinkaliWithCheeseAndMushrooms(int, int, int, int, int, int, int, int)
        +PrepareDough() string
        +PrepareFilling() string
    }
    
    Khinkali <|-- KhinkaliWithCheeseAndMushrooms