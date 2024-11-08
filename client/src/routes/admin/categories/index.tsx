import { createFileRoute } from '@tanstack/react-router'
import Layout from '../../../ui/admin/dashboard/layout'
import { CategoryTable } from '../../../ui/components/categories/category-list'

export const Route = createFileRoute('/admin/categories/')({
  component: () => <Layout>
    <CategoryTable/>
  </Layout>,
})