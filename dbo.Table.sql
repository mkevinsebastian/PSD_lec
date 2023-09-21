CREATE TABLE [dbo].[Cart]
(
	[CustomerID] INT NOT NULL PRIMARY KEY, 
    [AlbumID] INT NOT NULL, 
    [Qty] INT NOT NULL, 
    CONSTRAINT [FK_Cart_Customer] FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID), 
    CONSTRAINT [FK_Cart_Album] FOREIGN KEY (AlbumID) REFERENCES Album(AlbumID), 
)
