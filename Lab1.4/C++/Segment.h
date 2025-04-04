#pragma once

#include "Line.h"

class Segment : public Line {
public:
    // Constructor with parameters (explicitly calling the base class constructor)
    Segment(double x1, double y1, double x2, double y2) : Line(x1, y1, x2, y2) {}

    // Copy constructor
    Segment(const Segment& other) : Line(other) {}

    // Default constructor
    Segment() : Line() {}

    // Destructor
    ~Segment() {}

    // Method to double the length of the segment
    void doubleLength() {
        double dx = x2 - x1;
        double dy = y2 - y1;
        x2 = x1 + 2 * dx;
        y2 = y1 + 2 * dy;
    }
};