Feature: SetChessPieces
	As a Chessplayes I want chesspieces to play with.

Background: 
Given A chess board with '8' x '8' tiles

Scenario: Set chesspieces
	Given A set of all the chess set pieces on each team side.
	When The chessboard is loaded successfully
	Then The result on the chessboard should be filled on both team sides to start the game.

@pieces
Scenario: Set chesspieces on proper place
	Given The new board is created
	When The chessboard is loaded with chesspieces
	Then On each place a piece with the right colour should be set
	| Place | Piece | Colour |
	| A1    | Rook  | White  |
	| A2    | Knigh | White  |
	| A3    | Bishop| White  |
	| A4    | Queen | White  |
	| A5    | King  | White  |
	| A6    | Bishop| White  |
	| A7    | Knight| White  |
	| A8    | Rook  | White  |
	| B1    | Pawn  | White  |
	| B2    | Pawn  | White  |
	| B3    | Pawn  | White  |
	| B4    | Pawn  | White  |
	| B5    | Pawn  | White  |
	| B6    | Pawn  | White  |
	| B7    | Pawn  | White  |
	| B8    | Pawn  | White  |
	| H1    | Rook  | Black  |
	| H2    | Knight| Black  |
	| H3    | Bishop| Black  |
	| H4    | Queen | Black  |
	| H5    | King  | Black  |
	| H6    | Bishop| Black  |
	| H7    | Knight| Black  |
	| H8    | Rook  | Black  |
	| G1    | Pawn	| Black  |
	| G2    | Pawn  | Black  |
	| G3    | Pawn  | Black  |
	| G4    | Pawn  | Black  |
	| G5    | Pawn  | Black  |
	| G6    | Pawn  | Black  |
	| G7    | Pawn  | Black  |
	| G8    | Pawn  | Black  |

