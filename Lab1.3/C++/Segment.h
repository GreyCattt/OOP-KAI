#pragma once

#include <iostream>
#include <cmath>

class Segment {
private:
    double x1, y1, x2, y2;

public:
    // Default constructor
    Segment() : x1(0), y1(0), x2(1), y2(0) {}

    // Parameterized constructor
    Segment(double x1, double y1, double x2, double y2) : x1(x1), y1(y1), x2(x2), y2(y2) {}

    // Copy constructor
    Segment(const Segment& other) : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2) {}

    // Destructor
    ~Segment() {}

    // Method to calculate the length of the segment
    double getLength() const {
        return std::sqrt(std::pow(x2 - x1, 2) + std::pow(y2 - y1, 2));
    }

    // Method to get the segment's data
    void getData() const {
        std::cout << "Segment with endpoints: (" << x1 << ", " << y1 << "), (" << x2 << ", " << y2 << ")" << std::endl;
    }

    // Overloaded addition operator
    Segment operator+(const Segment& other) const {
        return Segment(x1 + other.x1, y1 + other.y1, x2 + other.x2, y2 + other.y2);
    }

    // Overloaded subtraction operator
    Segment operator-(double value) const {
        return Segment(x1 - value, y1, x2 - value, y2);
    }

    // Overloaded subtraction operator for multiple segments
    Segment operator-(const Segment& other) const {
        return Segment(x1 - other.x1, y1 - other.y1, x2 - other.x2, y2 - other.y2);
    }

    // Method to print the segment's information
    void printInfo() const {
        getData();
        std::cout << "Length = " << getLength() << std::endl;
    }
};