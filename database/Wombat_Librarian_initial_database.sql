ALTER TABLE IF EXISTS ONLY public.book DROP CONSTRAINT IF EXISTS pk_book_id CASCADE;
ALTER TABLE IF EXISTS ONLY public.category DROP CONSTRAINT IF EXISTS pk_category_id CASCADE;
ALTER TABLE IF EXISTS ONLY public.author DROP CONSTRAINT IF EXISTS pk_author_id CASCADE;
ALTER TABLE IF EXISTS ONLY public.user DROP CONSTRAINT IF EXISTS pk_user_id CASCADE;


DROP TABLE IF EXISTS public.book_author_junction;
CREATE TABLE "book_author_junction" (
  "authorId" int,
  "bookId" varchar
);

DROP TABLE IF EXISTS public.author;
CREATE TABLE "author" (
  "id" SERIAL PRIMARY KEY,
  "name" varchar
);

DROP TABLE IF EXISTS public.category_book_junction;
CREATE TABLE "category_book_junction" (
  "bookId" varchar,
  "categoryId" int
);

DROP TABLE IF EXISTS public.wishlist;
CREATE TABLE "wishlist" (
  "userId" int,
  "bookId" varchar
);

DROP TABLE IF EXISTS public.bookshelf;
CREATE TABLE "bookshelf" (
  "userId" int,
  "bookId" varchar
);

DROP TABLE IF EXISTS public.user;
CREATE TABLE "user" (
  "id" SERIAL PRIMARY KEY,
  "name" varchar,
  "hashedPass" varchar
);

DROP TABLE IF EXISTS public.book;
CREATE TABLE "book" (
  "id" varchar PRIMARY KEY,
  "title" varchar,
  "subtitle" varchar,
  "thumbnail" varchar,
  "description" varchar,
  "pageCount" int,
  "rating" float,
  "ratingCount" float,
  "language" varchar,
  "categoryId" int,
  "maturityRating" varchar,
  "published" varchar,
  "publisher" varchar
);

DROP TABLE IF EXISTS public.category;
CREATE TABLE "category" (
  "id" SERIAL PRIMARY KEY,
  "name" varchar
);



ALTER TABLE "book_author_junction" ADD FOREIGN KEY ("authorId") REFERENCES "author" ("id");

ALTER TABLE "book_author_junction" ADD FOREIGN KEY ("bookId") REFERENCES "book" ("id");

ALTER TABLE "wishlist" ADD FOREIGN KEY ("bookId") REFERENCES "book" ("id");

ALTER TABLE "wishlist" ADD FOREIGN KEY ("userId") REFERENCES "user" ("id");

ALTER TABLE "bookshelf" ADD FOREIGN KEY ("bookId") REFERENCES "book" ("id");

ALTER TABLE "bookshelf" ADD FOREIGN KEY ("userId") REFERENCES "user" ("id");

ALTER TABLE "category_book_junction" ADD FOREIGN KEY ("bookId") REFERENCES "book" ("id");

ALTER TABLE "category_book_junction" ADD FOREIGN KEY ("categoryId") REFERENCES "category" ("id");

