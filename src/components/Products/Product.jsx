import { useHttp } from '../../hooks/useHttp';

import ErrorBlock from '../../UI/ErrorBlock';

/* eslint-disable react/prop-types */
export default function Product({ productId }) {
  const {
    data: product,
    isLoading,
    error,
  } = useHttp(`products/${productId}`, {}, null);

  let content;

  if (isLoading) {
    content = <p>Loading data...</p>;
  }

  if (error) {
    content = (
      <ErrorBlock
        title={error.title}
        message={error.message}
      />
    );
  }

  if (Object.keys(product).length > 0) {
    content = (
      <article>
        <section>
          <img
            src={`http://localhost:8000/images/${product.image}`}
            alt={product.name}
          />
        </section>
        <section>
          <h3>{product.name}</h3>
          <p>{product.price}</p>
        </section>
      </article>
    );
  }

  return (
    <>
      <h2>Product page</h2>
      {content}
    </>
  );
}
