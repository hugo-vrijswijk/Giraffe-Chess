Feature: SetChessPieces
	As a Chessplayes I want chesspieces to play with.

@pieces
Scenario: Set chesspieces on proper place
	Given The new board is created
	Then On each place a piece with the right colour should be set
	| Place | Piece | Colour |
	| A1    | Rook  | White  |
	| B1    | Knight| White  |
	| C1    | Bishop| White  |
	| D1    | Queen | White  |
	| E1    | King  | White  |
	| F1    | Bishop| White  |
	| G1    | Knight| White  |
	| H1    | Rook  | White  |
	| A2    | Pawn  | White  |
	| B2    | Pawn  | White  |
	| C2    | Pawn  | White  |
	| D2    | Pawn  | White  |
	| E2    | Pawn  | White  |
	| F2    | Pawn  | White  |
	| G2    | Pawn  | White  |
	| H2    | Pawn  | White  |
	| A8    | Rook  | Black  |
	| B8    | Knight| Black  |
	| C8    | Bishop| Black  |
	| D8    | Queen | Black  |
	| E8    | King  | Black  |
	| F8    | Bishop| Black  |
	| G8    | Knight| Black  |
	| H8    | Rook  | Black  |
	| A7    | Pawn	| Black  |
	| B7    | Pawn  | Black  |
	| C7    | Pawn  | Black  |
	| D7    | Pawn  | Black  |
	| E7    | Pawn  | Black  |
	| F7    | Pawn  | Black  |
	| G7    | Pawn  | Black  |
	| H7    | Pawn  | Black  |

