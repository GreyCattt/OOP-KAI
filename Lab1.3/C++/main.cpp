#include <iostream>
#include "Segment.h"

int main() {
    // Create three Segment objects using different constructors
    Segment W1;
    Segment W2(1, 2, 3, 4);
    Segment W3(W2);

    // Print initial segments' information
    std::cout << "Initial segments:" << std::endl;
    std::cout << "W1:" << std::endl;
    W1.printInfo();
    std::cout << "W2:" << std::endl;
    W2.printInfo();
    std::cout << "W3:" << std::endl;
    W3.printInfo();

    // Move W3 3 units to the left along the X-axis
    W3 = W3 - 3;

    // Print W3 after moving
    std::cout << "\nW3 after moving 3 units to the left along the X-axis:" << std::endl;
    W3.printInfo();

    // Add W3 and W2 and store the result in W1
    W1 = W3 + W2;

    // Print the result
    std::cout << "\nW1 after adding W3 and W2:" << std::endl;
    W1.printInfo();

    return 0;
}