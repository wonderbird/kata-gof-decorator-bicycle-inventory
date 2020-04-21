# Bicycle Inventory

In this kata you implement the Gang Of Four Decorator Pattern [[1](#ref-1), [2](#ref-2), [3](#ref-3)].

Origins:

- Delbert Legg: [Bicycle Inventory Kata](https://gist.github.com/delbertlegg/1dc4ae8950c19c7c2407ec52bbd4aef0), [Sample Implementation](https://github.com/delbertlegg/Design-pattern-katas)

## Problem Description

Due to a string of thefts, it has been necessary to track bicycles and any accessories added in case anything turns up missing while parked in a public garage/bike rack. The program should allow existing bikes with accessory loadout to be entered as well as new accessories added to currently tracked bikes.

All items should track make, model, serial number (if applicable) and value. Any other things to save in order to help track or maintain items should be stored as well (such as bulb/battery types for lights, replacement brake part number, pedal cleat type). Accessories should include functional parts of the bike (such as brakes, derailleur, pedals, etc) as well as addons like lights and racks. The user should also have the ability to remove/replace accessories.

The program should aggregate the value of the bike as well as all accessories for quick insurance claims if necessary.

## Requirements

- Every bicycle and every accessory is described by the properties make, model, serial number and value.
- Bicycles can be decorated with the following items described by additional properties:
  - Lights: battery type, light bulb type
  - Brakes: brake style, part number

## Suggested Test Cases

1. Create a bike without accessories. Verify the bike is displayed correctly
2. Create a bike with a light. Verify the bike, the accessory and the price are displayed correctly
3. Create a bike with a light. Verify the bike, the accessory and the price are displayed correctly
4. Create a bike with a light and a brake. Verify the bike, the accessories and the price are displayed correctly

```
Sum value: $900.00
Bike: Montague, Navigator, A12345, $900.00

Sum value: $931.99
Bike: Montague, Navigator, A12345, $900.00
Light: Cree, Multifunction, 123, $31.99, Lithium Ion, LED

Sum value: $950.00
Bike: Montague, Navigator, A12345, $900.00
Brake: Shimano, Center pull, 123A456B, $50.00

Sum value: $981.99
Bike: Montague, Navigator, A12345, $900.00
Light: Cree, Multifunction, 123, $31.99, Lithium Ion, LED
Brake: Shimano, Center pull, 123A456B, $50.00
```

## Finishing Touches

- Avoid duplicated code (use `tools\dupfinder.bat`).
- Fix all static code analysis warnings.
- Check the Cyclomatic Complexity of your source code files. For me, the most complex class hat a value of 8 and the most complex method has a value of 5. See Visual Studio -> Analyze -> Calculate Code Metrics.

## References

<a name="ref-1">[1]</a> David Starr and others: "Decorator Design Pattern" in "Pluralsight: Design Patterns Library", https://www.pluralsight.com/courses/patterns-library, last visited on Apr. 17, 2020.

<a name="ref-2">[2]</a> Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides: "Design Patterns: Elements of Reusable Object-Oriented Software", Addison Wesley, 1994, pp. 151ff, [ISBN 0-201-63361-2](https://en.wikipedia.org/wiki/Special:BookSources/0-201-63361-2).

<a name="ref-3">[3]</a> Wikipedia: "Decorator pattern", https://en.wikipedia.org/wiki/Decorator_pattern, last visited on Apr. 16, 2020.
