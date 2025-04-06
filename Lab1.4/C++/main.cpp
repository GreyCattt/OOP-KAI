#include <iostream>
#include "Segment.h"

int main() {
    Segment segment(0, 0, 3, 4);

    // Output the initial data of the segment
    std::cout << "Initial segment data:" << std::endl;
    std::cout << "Start point: (" << segment.getX1() << ", " << segment.getY1() << ")" << std::endl;
    std::cout << "End point: (" << segment.getX2() << ", " << segment.getY2() << ")" << std::endl;
    std::cout << "Length: " << segment.getLength() << std::endl;

    // Double the length of the segment
    segment.doubleLength();

    // Output the updated data of the segment
    std::cout << "\nSegment data after doubling the length:" << std::endl;
    std::cout << "Start point: (" << segment.getX1() << ", " << segment.getY1() << ")" << std::endl;
    std::cout << "End point: (" << segment.getX2() << ", " << segment.getY2() << ")" << std::endl;
    std::cout << "Length: " << segment.getLength() << std::endl;

    return 0;
}