import { useSelector } from 'react-redux';
import { useHttp } from '../../hooks/useHttp';
import ErrorBlock from '../../UI/ErrorBlock';
import Multiselect from '../../UI/Multiselect';

var INITIAL_CONFIG = {};

/*
TODO:
- Hibajelzés javítás: ne mindig a categories helyett legyen a hibaüzenet, hanem csak akkor, ha a kategóriák betöltése közben történt hiba. Ha bármi máskor történik hiba, akkor egy központi hibaüzenet jelenjen meg.
- Sikeres mentés esetén a form visszaállítása és egy sikeres mentésről tájékoztató üzenet megjelenítése/visszanavigálás a Products oldalra.
 */

export default function NewProduct() {
  var { data, isLoading, error, sendRequest } = useHttp(
    'categories',
    [],
    INITIAL_CONFIG
  );

  const categories = useSelector(
    (state) => state.categories.selectedCategories
  );

  function handleSubmit(event) {
    event.preventDefault();

    const fd = new FormData(event.target);
    const customerData = Object.fromEntries(fd.entries());

    sendRequest(
      'products',
      JSON.stringify({
        name: customerData.name,
        categories: categories,
        description: customerData.description,
        //image: customerData.image,
        price: customerData.price,
      })
    );
  }

  var categoriesContent;
  if (isLoading) {
    categoriesContent = 'Loading categories...';
  }

  if (error) {
    categoriesContent = (
      <ErrorBlock
        title={error.title}
        message={error.message}
      />
    );
  }

  if (!isLoading && !error && data.categories) {
    categoriesContent = (
      <Multiselect>
        {data.categories.map((cat) => (
          <option
            key={cat.id}
            value={cat.id}
          >
            {cat.name}
          </option>
        ))}
      </Multiselect>
    );
  }

  return (
    <form onSubmit={handleSubmit}>
      <p>
        <label htmlFor="name">Product name</label>
        <input
          type="text"
          id="name"
          name="name"
        ></input>
      </p>
      <p>
        <label htmlFor="categories">Categories</label>
        {categoriesContent}
      </p>
      <p>
        <label htmlFor="description">Description</label>
        <input
          type="text"
          id="description"
          name="description"
        ></input>
      </p>
      <p>
        <label htmlFor="image">Image</label>
        <input
          type="file"
          id="image"
          name="image"
        ></input>
      </p>
      <p>
        <label htmlFor="price">Price</label>
        <input
          type="text"
          id="price"
          name="price"
        ></input>
      </p>
      <p>
        <button type="submit">Save</button>
      </p>
    </form>
  );
}
