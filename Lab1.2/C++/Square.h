#pragma once

#include <iostream>
#include <cmath>

class Square {
private:
    double x1, y1, x2, y2, x3, y3, x4, y4;

public:
    // Default constructor
    Square() : x1(0), y1(0), x2(1), y2(0), x3(1), y3(1), x4(0), y4(1) {}

    // Parameterized constructor
    Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        : x1(x1), y1(y1), x2(x2), y2(y2), x3(x3), y3(y3), x4(x4), y4(y4) {
        if (!checkEqualSides()) {
            throw std::invalid_argument("The provided coordinates do not form a square.");
        }
    }

    // Copy constructor
    Square(const Square& other)
        : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2), x3(other.x3), y3(other.y3), x4(other.x4), y4(other.y4) {}

    // Destructor
    ~Square() {}

    // Getters
    double getX1() const { return x1; }
    double getY1() const { return y1; }
    double getX2() const { return x2; }
    double getY2() const { return y2; }
    double getX3() const { return x3; }
    double getY3() const { return y3; }
    double getX4() const { return x4; }
    double getY4() const { return y4; }

    // Method to check if the sides are equal
    bool checkEqualSides() const {
        double sides[4] = {
            std::sqrt(std::pow(x2 - x1, 2) + std::pow(y2 - y1, 2)),
            std::sqrt(std::pow(x3 - x2, 2) + std::pow(y3 - y2, 2)),
            std::sqrt(std::pow(x4 - x3, 2) + std::pow(y4 - y3, 2)),
            std::sqrt(std::pow(x1 - x4, 2) + std::pow(y1 - y4, 2))
        };

        for (int i = 1; i < 4; ++i) {
            if (sides[i] != sides[0]) {
                return false;
            }
        }

        double diameters[2] = {
            std::sqrt(std::pow(x3 - x1, 2) + std::pow(y3 - y1, 2)),
            std::sqrt(std::pow(x4 - x2, 2) + std::pow(y4 - y2, 2))
        };

        return diameters[0] == diameters[1];
    }

    // Method to calculate the side length
    double getSideLength() const {
        return std::sqrt(std::pow(x2 - x1, 2) + std::pow(y2 - y1, 2));
    }

    // Method to calculate the perimeter
    double getPerimeter() const {
        return 4 * getSideLength();
    }

    // Method to calculate the area
    double getArea() const {
        return std::pow(getSideLength(), 2);
    }

    // Method to output the square's information
    void printInfo() const {
        std::cout << "Square with vertices: (" << x1 << ", " << y1 << "), ("
                  << x2 << ", " << y2 << "), (" << x3 << ", " << y3 << "), ("
                  << x4 << ", " << y4 << ")\nPerimeter = " << getPerimeter()
                  << "\nArea = " << getArea() << std::endl;
    }
};