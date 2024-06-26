import { useParams } from 'react-router';
import Product from '../components/Products/Product';

export default function ProductItemPage() {
  const params = useParams();
  return <Product productId={params.id} />;
}

// TODO: errohandling ha nem létező id-t adtak meg
