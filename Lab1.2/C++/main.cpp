#include <iostream>
#include "Square.h"

int main() {
    try {
        // Prompt the user for the coordinates of the square's vertices
        std::cout << "Enter the coordinates of the square's vertices:" << std::endl;

        double x1, y1, x2, y2, x3, y3, x4, y4;

        std::cout << "X1: ";
        std::cin >> x1;
        std::cout << "Y1: ";
        std::cin >> y1;

        std::cout << "X2: ";
        std::cin >> x2;
        std::cout << "Y2: ";
        std::cin >> y2;

        std::cout << "X3: ";
        std::cin >> x3;
        std::cout << "Y3: ";
        std::cin >> y3;

        std::cout << "X4: ";
        std::cin >> x4;
        std::cout << "Y4: ";
        std::cin >> y4;

        // Create a Square object using the parameterized constructor
        Square square(x1, y1, x2, y2, x3, y3, x4, y4);

        // Display the square's information
        square.printInfo();
    } catch (const std::exception& ex) {
        std::cerr << "Error: " << ex.what() << std::endl;
        std::cerr << "Creating a default square." << std::endl;

        // Create a Square object using the default constructor
        Square defaultSquare;
        defaultSquare.printInfo();
    }

    return 0;
}