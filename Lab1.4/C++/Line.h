#pragma once

#include <cmath>

class Line {
protected:
    double x1, y1, x2, y2;

public:
    // Constructor with parameters
    Line(double x1, double y1, double x2, double y2) : x1(x1), y1(y1), x2(x2), y2(y2) {}

    // Copy constructor
    Line(const Line& other) : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2) {}

    // Default constructor
    Line() : x1(0), y1(0), x2(1), y2(1) {}

    // Destructor
    virtual ~Line() {}

    // Method to calculate the length of the line
    double getLength() const {
        return std::sqrt(std::pow(x2 - x1, 2) + std::pow(y2 - y1, 2));
    }

    // Getters for the coordinates
    double getX1() const { return x1; }
    double getY1() const { return y1; }
    double getX2() const { return x2; }
    double getY2() const { return y2; }
};