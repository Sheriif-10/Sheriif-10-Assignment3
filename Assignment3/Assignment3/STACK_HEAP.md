# Stack & Heap

## Diagram 1 — After line 1

```text
STACK                         HEAP

┌──────────────────┐          ┌────────────────────────┐
│ o1               │          │ Address: 0x1000        │
│ 0x1000 ──────────┼─────────>│                        │
└──────────────────┘          │ OrderId = 1            │
                              │ CustomerName = "Ali"   │
                              │ IsPaid = false         │
                              └────────────────────────┘


STACK                         HEAP

┌──────────────────┐
│ o1               │          ┌────────────────────────┐
│ 0x1000 ──────────┼─────────>│ Address: 0x1000        │
└──────────────────┘          │                        │
                              │ OrderId = 1            │
┌──────────────────┐          │ CustomerName = "Ali"   │
│ o2               │          │ IsPaid = false         │
│ 0x1000 ──────────┼─────────>│                        │
└──────────────────┘          └────────────────────────┘










STACK                         HEAP

┌──────────────────┐
│ o1               │          ┌────────────────────────┐
│ 0x1000 ──────────┼─────────>│ Address: 0x1000        │
└──────────────────┘          │                        │
                              │ OrderId = 1            │
┌──────────────────┐          │ CustomerName = "Ali"   │
│ o2               │          │ IsPaid = TRUE          │
│ 0x1000 ──────────┼─────────>│                        │
└──────────────────┘          └────────────────────────┘





What would be different with structs?

If Order were a struct instead of a class, assigning o1 to o2 would copy the entire value,
so o1 and o2 would have separate copies.Changing o2.IsPaid would therefore not change o1.IsPaid