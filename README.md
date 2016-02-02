# EF Disconnected Tests

Compares EF 6 to EF Core for painting state on disconnected graphs.

*Tests may be run via the Test Explorer in VS 2015.*

EF6.Disconnected.Tests shows that setting entity state to Added on 
a parent entity will also set child entity states to Added.

EFCore.Disconnected.Tests shows that setting entity state to Added on
a parent entity will not set child entity states.

*I will plan to add more tests in the future.*
