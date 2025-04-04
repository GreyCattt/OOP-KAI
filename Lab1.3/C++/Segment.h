#pragma once

#include <iostream>
#include <cmath>
#include <cstdarg>

class Segment {
private:
    double x1, y1, x2, y2;

public:
    Segment() : x1(0), y1(0), x2(1), y2(0) {}

    Segment(double x1, double y1, double x2, double y2) : x1(x1), y1(y1), x2(x2), y2(y2) {}

    // Copy constructor
    Segment(const Segment& other) : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2) {}

    ~Segment() {}

    double getLength() const {
        return std::sqrt(std::pow(x2 - x1, 2) + std::pow(y2 - y1, 2));
    }

    void getData() const {
        std::cout << "Segment with endpoints: (" << x1 << ", " << y1 << "), (" << x2 << ", " << y2 << ")" << std::endl;
    }

    Segment operator+(const Segment& other) const {
        return Segment(x1 + other.x1, y1 + other.y1, x2 + other.x2, y2 + other.y2);
    }

    Segment operator-(double value) const {
        return Segment(x1 - value, y1, x2 - value, y2);
    }

    Segment operator-(const Segment& other) const {
        return Segment(x1 - other.x1, y1 - other.y1, x2 - other.x2, y2 - other.y2);
    }

    void printInfo() const {
        getData();
        std::cout << "Length = " << getLength() << std::endl;
    }

    // Передача параметрів за посиланням
    void setEndpoints(const Segment& other) {
        x1 = other.x1;
        y1 = other.y1;
        x2 = other.x2;
        y2 = other.y2;
    }

    // Аргументи за умовчанням
    void move(double dx = 1.0, double dy = 0.0) {
        x1 += dx;
        y1 += dy;
        x2 += dx;
        y2 += dy;
    }

    // Змінна кількість параметрів
    void setCoordinates(int count, ...) {
        va_list args;
        va_start(args, count);
        if (count >= 4) {
            x1 = va_arg(args, double);
            y1 = va_arg(args, double);
            x2 = va_arg(args, double);
            y2 = va_arg(args, double);
        }
        va_end(args);
    }
};