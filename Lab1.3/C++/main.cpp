#include <iostream>
#include "Segment.h"

int main() {
    
    Segment W1;
    Segment W2(1, 2, 3, 4);
    Segment W3(W2);

    std::cout << "Initial segments:" << std::endl;
    std::cout << "W1:" << std::endl;
    W1.printInfo();
    std::cout << "W2:" << std::endl;
    W2.printInfo();
    std::cout << "W3:" << std::endl;
    W3.printInfo();
    
    W3 = W3 - 3;
    
    std::cout << "\nW3 after moving 3 units to the left along the X-axis:" << std::endl;
    W3.printInfo();
    
    W1 = W3 + W2;

    std::cout << "\nW1 after adding W3 and W2:" << std::endl;
    W1.printInfo();

    return 0;
}